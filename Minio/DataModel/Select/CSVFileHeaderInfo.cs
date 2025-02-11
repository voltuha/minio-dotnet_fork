/*
 * MinIO .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2020 MinIO, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Xml.Serialization;

namespace Minio.DataModel;

[Serializable]
public sealed class CSVFileHeaderInfo
{
    // Constants for file header info.
    public static readonly CSVFileHeaderInfo None = new("NONE");
    public static readonly CSVFileHeaderInfo Ignore = new("IGNORE");
    public static readonly CSVFileHeaderInfo Use = new("USE");

    public CSVFileHeaderInfo()
    {
    }

    public CSVFileHeaderInfo(string value)
    {
        HeaderInfo = value;
    }

    [XmlText] public string HeaderInfo { get; set; }
}