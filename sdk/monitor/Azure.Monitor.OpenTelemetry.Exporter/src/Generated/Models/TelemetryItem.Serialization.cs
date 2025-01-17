// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class TelemetryItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("ver");
                writer.WriteNumberValue(Version.Value);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("time");
            writer.WriteStringValue(Time, "O");
            if (Optional.IsDefined(SampleRate))
            {
                writer.WritePropertyName("sampleRate");
                writer.WriteNumberValue(SampleRate.Value);
            }
            if (Optional.IsDefined(Sequence))
            {
                writer.WritePropertyName("seq");
                writer.WriteStringValue(Sequence);
            }
            if (Optional.IsDefined(InstrumentationKey))
            {
                writer.WritePropertyName("iKey");
                writer.WriteStringValue(InstrumentationKey);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteObjectValue(Data);
            }
            writer.WriteEndObject();
        }
    }
}
