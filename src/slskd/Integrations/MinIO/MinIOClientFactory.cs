// <copyright file="MinIOClientFactory.cs" company="slskd Team">
//     Copyright (c) slskd Team. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as published
//     by the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
//
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see https://www.gnu.org/licenses/.
// </copyright>

using Microsoft.Extensions.Options;

namespace slskd.Integrations.MinIO
{
    using Minio;
    using static slskd.Options.IntegrationOptions;

    /// <summary>
    ///    MinIO client factory.
    /// </summary>
    public class MinIOClientFactory : IMinIOClientFactory
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MinIOClientFactory"/> class.
        /// </summary>
        /// <param name="optionsMonitor">The options monitor used to derive application options.</param>
        public MinIOClientFactory(IOptionsMonitor<Options> optionsMonitor)
        {
            OptionsMonitor = optionsMonitor;
        }

        private MinioOptions MinioOptions => OptionsMonitor.CurrentValue.Integration.Minio;
        private IOptionsMonitor<Options> OptionsMonitor { get; set; }

        /// <summary>
        ///     Creates an instance of <see cref="MinioClient"/>.
        /// </summary>
        /// <returns>The created instance.</returns>
        public MinioClient CreateMinIOClient()
        {
            var client = new MinioClient();

            return client;
        }
    }
}