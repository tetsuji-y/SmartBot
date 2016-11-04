using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBot.Domain.Model.Command
{
    public abstract class BotCommand
    {
        public abstract string CommandText { get; }

        public abstract void Initialize();

        public abstract void ExecuteCore();

        public virtual void Execute()
        {
            Initialize();

            ExecuteCore();
        }
    }

    public class ChatBotCommand : BotCommand
    {
        public override string CommandText => "chat";

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }

    public class DeployBotCommand : BotCommand
    {
        public override string CommandText => "deploy";

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }

    public class BuildBotCommand : BotCommand
    {
        public override string CommandText => "build";

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }

}
