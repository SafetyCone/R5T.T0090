using System;


namespace R5T.T0090
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class JsonKey : IJsonKey
    {
        #region Static
        
        public static JsonKey Instance { get; } = new();

        #endregion
    }
}