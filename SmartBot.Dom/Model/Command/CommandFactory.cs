using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Reflection;

namespace SmartBot.Domain.Model.Command
{
    public class CommandFactory
    {
        private static readonly IReadOnlyDictionary<string, BotCommand> InstanceList;

        static CommandFactory()
        {
            InstanceList = new ReadOnlyDictionary<string, BotCommand>(
                typeof(CommandFactory).
                .Where(x => (x.IsClass && !x.IsAbstract) && x.IsSubclassOf(typeof(BotCommand)))
                .Select(x => (BotCommand)Activator.CreateInstance(x.GetType()))
                .ToDictionary(x => x.CommandText)
                );
        }

        public static BotCommand Create(string command)
        {
            return InstanceList.ContainsKey(command) ? InstanceList[command] : null;
        }
    }
}
