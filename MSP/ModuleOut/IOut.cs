using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOut
{
    /// <summary>
    /// interface for output result of calculations
    /// </summary>
    public interface IOut
    {

        string Format { get; }
        /// <summary>
        /// type of result 
        /// </summary>
        Type type { get; }
        /// <summary>
        /// string witch will be prompted before result
        /// </summary>
        string Prompt { get; }
        string Value { get; }
        /// <summary>
        /// Precision of result
        /// </summary>
        string Precision();
        void Out(object result);
    }
}
