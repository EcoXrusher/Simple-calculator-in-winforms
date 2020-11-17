using System;
using System.Collections.Generic;
using System.Text;

namespace Apka_okienkowa_WinForms
{
    /// <summary>
    /// holds information about calculation
    /// </summary>
    public class Operation
    {
        #region public properties
        public string LeftSide { get; set; }
        public string RightSide { get; set; }

        public OperationTypes OperationType { get; set; }

        public Operation InnerOperation { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default counstructor
        /// </summary>
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion

    }
}
