﻿using System;
using System.Net.Http;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Deepgram.Request;

namespace Deepgram.Transcription
{
    internal class PrerecordedTranscriptionClient : IPrerecordedTranscriptionClient
    {
        private CleanCredentials _credentials;

        public PrerecordedTranscriptionClient(CleanCredentials credentials)
        {
            _credentials = credentials;
        }

        /// <summary>
        /// Submits a request to the Deepgram API to transcribe prerecorded audio
        /// </summary>
        /// <param name="source">Url source to send for transcription</param>
        /// <param name="options">Feature options for the transcription</param>
        /// <returns>Transcription of the provided audio</returns>
        public async Task<PrerecordedTranscription> GetTranscriptionAsync(UrlSource source, PrerecordedTranscriptionOptions? options)
        {
            return await ApiRequest.DoRequestAsync<PrerecordedTranscription>(
                HttpMethod.Post,
                "/v1/listen",
                _credentials,
                options,
                source);
        }

        /// <summary>
        /// Submits a request to the Deepgram API to transcribe prerecorded audio
        /// </summary>
        /// <param name="source">Audio source to send for transcription</param>
        /// <param name="options">Feature options for the transcription</param>
        /// <returns>Transcription of the provided audio</returns>
        public async Task<PrerecordedTranscription> GetTranscriptionAsync(StreamSource source, PrerecordedTranscriptionOptions? options)
        {
            return await ApiRequest.DoStreamRequestAsync<PrerecordedTranscription>(
                HttpMethod.Post,
                "/v1/listen",
                _credentials,
                source,
                options);
        }
    }
}
