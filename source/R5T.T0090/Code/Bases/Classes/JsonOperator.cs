using System;


namespace R5T.T0090
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class JsonOperator : IJsonOperator
    {
        #region Static
        
        public static JsonOperator Instance { get; } = new();

        #endregion
    }
}