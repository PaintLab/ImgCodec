﻿//Apache2, 2012, Hernan J. González, (https://github.com/leonbloy)
//Apache2, 2017, WinterDev
namespace Hjg.Pngcs
{

    using System;

    /// <summary>
    /// Exception for unsupported operation or feature
    /// </summary>
    [Serializable]
    public class PngjUnsupportedException : Exception
    {
        private const long serialVersionUID = 1L;

        public PngjUnsupportedException()
            : base()
        {
        }

        public PngjUnsupportedException(String message, Exception cause)
            : base(message, cause)
        {
        }

        public PngjUnsupportedException(String message)
            : base(message)
        {
        }

        public PngjUnsupportedException(Exception cause)
            : base(cause.Message, cause)
        {
        }
    }
}
