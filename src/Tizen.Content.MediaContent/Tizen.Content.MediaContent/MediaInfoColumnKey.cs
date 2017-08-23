/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Content.MediaContent
{
    /// <summary>
    /// Specifies group keys for <see cref="MediaInfo"/>.
    /// </summary>
    public enum MediaInfoColumnKey
    {
        /// <summary>
        /// Display name.
        /// </summary>
        DisplayName,
        /// <summary>
        /// Media type.
        /// </summary>
        Type,
        /// <summary>
        /// Mime type.
        /// </summary>
        MimeType,
        /// <summary>
        /// File size.
        /// </summary>
        Size,
        /// <summary>
        /// Date added.
        /// </summary>
        DateAdded,
        /// <summary>
        /// Date modified.
        /// </summary>
        DateModified,
        /// <summary>
        /// Content title.
        /// </summary>
        Title,
        /// <summary>
        /// Artist.
        /// </summary>
        Artist,
        /// <summary>
        /// Album artist.
        /// </summary>
        AlbumArtist,
        /// <summary>
        /// Genre.
        /// </summary>
        Genre,
        /// <summary>
        /// Composer.
        /// </summary>
        Composer = 10,
        /// <summary>
        /// Year.
        /// </summary>
        Year,
        /// <summary>
        /// Date recorded.
        /// </summary>
        DateRecorded,
        /// <summary>
        /// Copyright.
        /// </summary>
        Copyright,
        /// <summary>
        /// Track number.
        /// </summary>
        TrackNumber,
        /// <summary>
        /// Description.
        /// </summary>
        Description,
        /// <summary>
        /// Longitude.
        /// </summary>
        Longitude,
        /// <summary>
        /// Latitude.
        /// </summary>
        Latitude,
        /// <summary>
        /// Altitude.
        /// </summary>
        Altitude,
        /// <summary>
        /// Burst shot.
        /// </summary>
        BurstImage,
        /// <summary>
        /// Rating.
        /// </summary>
        Rating = 20,

        /// <summary>
        /// Provider.
        /// </summary>
        Provider = 22,

        /// <summary>
        /// Category.
        /// </summary>
        Category = 24,
        /// <summary>
        /// Location tag.
        /// </summary>
        LocationTag,
        /// <summary>
        /// Age rating.
        /// </summary>
        AgeRating,
        /// <summary>
        /// Weather.
        /// </summary>
        Weather = 28
    }
}