﻿using System;

namespace Oxide.Core.Libraries
{
    /// <summary>
    /// The time library
    /// </summary>
    public class Time : Library
    {
        /// <summary>
        /// Returns if this library should be loaded into the global namespace
        /// </summary>
        public override bool IsGlobal => false;

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        /// <summary>
        /// Returns a Unix timestamp for the current time
        /// </summary>
        /// <returns></returns>
        [LibraryFunction("GetUnixTimestamp")]
        public uint GetUnixTimestamp() => (uint)DateTime.UtcNow.Subtract(Epoch).TotalSeconds;

        /// <summary>
        /// Returns DateTime.UtcNow
        /// </summary>
        /// <returns></returns>
        [LibraryFunction("GetCurrentTime")]
        public DateTime GetCurrentTime() => DateTime.UtcNow;
    }
}
