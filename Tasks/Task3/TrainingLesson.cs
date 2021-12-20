using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task3
{
    internal class TrainingLesson : Training, IVersionable, ICloneable
    {
        private byte[] version = new byte[8];

        private TrainingMaterial[] TrainingMaterial { get; set; }

        public TrainingLesson (TrainingMaterial[] trainingMaterial, string? description) : base(description)
        {
            TrainingMaterial = trainingMaterial;
        }

        public LessonType DefineTypeOfLesson()
        {
            foreach (TrainingMaterial material in TrainingMaterial)
            {
                if (material is VideoMaterial)
                {
                    return LessonType.VideoLesson;
                }
            }
                return LessonType.TextLesson;
        }

        public override string? ToString()
        {
            StringBuilder trainingLessonString = new StringBuilder("Lesson type: " + DefineTypeOfLesson() + "\nVersion: " + ReadVersion());
            foreach (TrainingMaterial material in TrainingMaterial)
            {   
                trainingLessonString.Append("\nTraining Material:\n" + material.ToString() + " ");
            };
            return trainingLessonString.ToString();
        }

        public void SetVersion()
        {
            {
                Random rnd = new Random();
                rnd.NextBytes(version);
            }
        }

        public string ReadVersion()
        {
            if (version[0]!=0)
            {
                return BitConverter.ToString(version);
                //Convert.ToBase64String(version);}
            }
            else return "Version is not set";
        }

            public object Clone()
        {
            TrainingMaterial[] newTrainingMaterial = new TrainingMaterial[TrainingMaterial.Length];
            TrainingMaterial.CopyTo(newTrainingMaterial, 0);
            TrainingLesson clonedTrainingLesson = new TrainingLesson(newTrainingMaterial, Description);
            clonedTrainingLesson.version = this.version;
            return clonedTrainingLesson;   
        }
    }
}
