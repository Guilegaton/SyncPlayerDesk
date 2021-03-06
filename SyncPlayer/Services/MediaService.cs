﻿using SyncPlayer.Models;
using System.Collections.Generic;
using System.Linq;
using TagLib;

namespace SyncPlayer.Services
{
    public class MediaService
    {
        #region Public Methods

        public Media GetMedia(string fullPath)
        {
            Media result = null;
            if (string.IsNullOrEmpty(fullPath) && System.IO.File.Exists(fullPath))
            {
                using (File file = File.Create(fullPath))
                {
                    result = new Media
                    {
                        Name = file.Name,
                        Duration = file.Properties.Duration,
                        FileName = fullPath,
                        Type = file.Properties.MediaTypes.ToString(),
                        Genre = file.Tag.Genres.Aggregate((cur, next) => $"{cur},{next}"),
                        Singler = file.Tag.Artists.Aggregate((cur, next) => $"{cur},{next}"),
                        BitRate = file.Properties.AudioBitrate,
                        Rate = file.Properties.AudioSampleRate,
                        Album = file.Tag.Album,
                        Description = file.Properties.Description,
                        MimeType = file.MimeType,
                        StartPosition = file.InvariantStartPosition,
                        EndPostiotion = file.InvariantEndPosition
                    };
                }
            }

            return result;
        }

        public IEnumerable<Media> GetMedia(params string[] fullPaths)
        {
            List<Media> result = new List<Media>();
            foreach (var fullPath in fullPaths.Where(path => !string.IsNullOrEmpty(path) && System.IO.File.Exists(path)))
            {
                using (File file = File.Create(fullPath))
                {
                    var mediaFile = new Media
                    {
                        Name = file.Name,
                        Duration = file.Properties.Duration,
                        FileName = fullPath,
                        Type = file.Properties.MediaTypes.ToString(),
                        Genre = file.Tag.Genres.Aggregate((cur, next) => $"{cur},{next}"),
                        Singler = file.Tag.Artists.Aggregate((cur, next) => $"{cur},{next}"),
                        BitRate = file.Properties.AudioBitrate,
                        Rate = file.Properties.AudioSampleRate,
                        Album = file.Tag.Album,
                        Description = file.Properties.Description,
                        MimeType = file.MimeType,
                        StartPosition = file.InvariantStartPosition,
                        EndPostiotion = file.InvariantEndPosition
                    };
                    result.Add(mediaFile);
                }
            }
            return result;
        }

        #endregion Public Methods
    }
}