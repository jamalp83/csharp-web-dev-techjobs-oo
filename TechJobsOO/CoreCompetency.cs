﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int Id { get; }
        private static int nextId = 1;

        // TODO: Change the fields to auto-implemented properties.
        public string Value { get; set; }

        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
