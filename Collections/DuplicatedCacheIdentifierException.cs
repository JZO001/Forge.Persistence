﻿/* *********************************************************************
 * Date: 18 Apr 2012
 * Created by: Zoltan Juhasz
 * E-Mail: forge@jzo.hu
***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace Forge.Persistence.Collections
{

    /// <summary>
    /// Occurs when the cache identifier already exist
    /// </summary>
    [Serializable]
    public class DuplicatedCacheIdentifierException : Exception
    {

        #region Constructor(s)

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatedCacheIdentifierException"/> class.
        /// </summary>
        public DuplicatedCacheIdentifierException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatedCacheIdentifierException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public DuplicatedCacheIdentifierException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatedCacheIdentifierException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        public DuplicatedCacheIdentifierException(string message, Exception ex) : base(message, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicatedCacheIdentifierException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
        protected DuplicatedCacheIdentifierException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion

    }

}
