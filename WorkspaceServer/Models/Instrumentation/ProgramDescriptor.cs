﻿using System;
using System.Linq;
using Newtonsoft.Json;
using WorkspaceServer.Models.Execution;

namespace WorkspaceServer.Models.Instrumentation
{
    public class ProgramDescriptor : IRunResultFeature
    {
        [JsonProperty("variableLocations")]
        public VariableLocation[] VariableLocations { get; set; }

        public void Apply(RunResult result)
        {
            result.AddProperty("variableLocations", VariableLocations);
        }

    }
    public partial class VariableLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locations")]
        public Location[] Locations { get; set; }

        [JsonProperty("declaredAt")]
        public DeclaredAt DeclaredAt { get; set; }
    }

    public partial class DeclaredAt
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("startLine")]
        public long StartLine { get; set; }

        [JsonProperty("startColumn")]
        public long StartColumn { get; set; }

        [JsonProperty("endLine")]
        public long EndLine { get; set; }

        [JsonProperty("endColumn")]
        public long EndColumn { get; set; }
    }
}
