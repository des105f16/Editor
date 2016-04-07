using SablePP.Tools.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Wpf
{
    public abstract class ErrorViewTypes
    {
        private CompilerError error;

        public ErrorViewTypes(CompilerError error)
        {
            this.error = error;
        }

        public static ErrorViewTypes Wrap(CompilerError error)
        {
            switch (error.ErrorType)
            {
                case ErrorType.Error:
                    return new Error(error);
                case ErrorType.Warning:
                    return new Warning(error);
                case ErrorType.Message:
                default:
                    return new Message(error);
            }
        }

        public string Message => error.ErrorMessage;
        public int Line => error.Start.Line;
        public int Character => error.Start.Character;
    }
    public class Error : ErrorViewTypes
    {
        public Error(CompilerError error) : base(error)
        {
        }
    }
    public class Warning : ErrorViewTypes
    {
        public Warning(CompilerError error) : base(error)
        {
        }
    }
    public class Message : ErrorViewTypes
    {
        public Message(CompilerError error) : base(error)
        {
        }
    }
}
