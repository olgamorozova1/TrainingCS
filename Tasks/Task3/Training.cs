﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal abstract class Training
    {
        public Guid Guid { get; set; }
        private string? description;

        protected Training(string? description)
        {
            Guid = Guid.NewGuid();
            ValidateAndSetDescription(description);
        }

        public string? Description
        {
            get
            {
                return description;
            }

            set
            {
                ValidateAndSetDescription(value);
            }
        }

        private void ValidateAndSetDescription (string? description)
        {
            if (description != null && description.Length > 256)
            {
                throw new Exception("Description length is excedeeded");  
            }
            else
            {
               this.description = description;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            Training training = obj as Training;
            if (training != null)
            {
                return this.Guid == training.Guid;
            }
            else return false;

        }
    }
}
