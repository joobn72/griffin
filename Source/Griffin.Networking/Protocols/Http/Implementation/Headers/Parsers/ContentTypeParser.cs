﻿using System;
using Griffin.Networking.Buffers;

namespace Griffin.Networking.Protocols.Http.Implementation.Headers.Parsers
{
    /// <summary>
    /// Parses <see cref="ContentTypeHeader"/>.
    /// </summary>
    [ParserFor(ContentTypeHeader.NAME)]
    public class ContentTypeParser : IHeaderParser
    {
        #region IHeaderParser Members

        /// <summary>
        /// Parse a header
        /// </summary>
        /// <param name="name">Name of header.</param>
        /// <param name="reader">Reader containing value.</param>
        /// <returns>HTTP Header</returns>
        /// <exception cref="FormatException">Header value is not of the expected format.</exception>
        public IHeader Parse(string name, ITextParser reader)
        {
            string contentType = reader.ReadToEnd(';');

            // got parameters
            if (reader.Current == ';')
            {
                HeaderParameterCollection parameters = HeaderParameterCollection.Parse(reader);
                return new ContentTypeHeader(contentType, parameters);
            }

            return new ContentTypeHeader(contentType);
        }

        #endregion
    }
}