﻿namespace Workspace
{
    public class Modifier
    {
        public Modifier(string name)
        {
            Name = name;
        }

        public Modifier() : this("Empty_Modifier"){}

        public BlankID? Id {get; set; }
        public BlankType? Type {get; set; }
        public string? Name {get; set;}
        public int? Cost {get; set;}
        public bool? Disabled {get; set;}
        public string? Notes {get; set;}
        public string? Affects {get; set;}
        public string? CostType {get; set;}
    }
}
