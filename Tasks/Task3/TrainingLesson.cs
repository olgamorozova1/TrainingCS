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
                trainingLessonString.Append("\nTraining Material:\n" + material.ToString());
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

        public byte[] ReadVersion()
        {
            return version;
        }

            public object Clone()
        {
            TrainingMaterial[] clonedTrainingMaterial = new TrainingMaterial[TrainingMaterial.Length];
            for (int i = 0; i < TrainingMaterial.Length; i++)
            {
                clonedTrainingMaterial[i] = (TrainingMaterial)TrainingMaterial[i].Clone();
            }
            TrainingLesson clonedTrainingLesson = new TrainingLesson(clonedTrainingMaterial, Description);
            clonedTrainingLesson.version = this.version;
            return clonedTrainingLesson;   
        }
    }
}
