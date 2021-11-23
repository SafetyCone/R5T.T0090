using System;


namespace R5T.T0090
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Json : IJson
    {
        #region Static
        
        public static Json Instance { get; } = new();

        #endregion
    }
}