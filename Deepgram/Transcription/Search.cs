﻿using System;
using Newtonsoft.Json;

namespace Deepgram.Transcription
{
    public class Search
    {
        /// <summary>
        /// Term for which Deepgram is searching.
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// Array of Hit objects
        /// </summary>
        [JsonProperty("hits")]
        public Hit[] Hits { get; set; }
    }
}
