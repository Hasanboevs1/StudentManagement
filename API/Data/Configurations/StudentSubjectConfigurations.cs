using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations;

public class StudentSubjectConfigurations : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasData(
                new StudentSubject { StudentId = 1, SubjectId = 1, Grade = 85.0 },
                new StudentSubject { StudentId = 1, SubjectId = 2, Grade = 90.0 },
                new StudentSubject { StudentId = 2, SubjectId = 1, Grade = 78.0 },
                new StudentSubject { StudentId = 2, SubjectId = 3, Grade = 82.0 },
                new StudentSubject { StudentId = 3, SubjectId = 2, Grade = 88.0 },
                new StudentSubject { StudentId = 3, SubjectId = 4, Grade = 91.0 },
                new StudentSubject { StudentId = 4, SubjectId = 5, Grade = 75.0 },
                new StudentSubject { StudentId = 4, SubjectId = 6, Grade = 85.0 },
                new StudentSubject { StudentId = 5, SubjectId = 7, Grade = 92.0 },
                new StudentSubject { StudentId = 5, SubjectId = 8, Grade = 80.0 },
                new StudentSubject { StudentId = 6, SubjectId = 3, Grade = 82.0 },
                new StudentSubject { StudentId = 6, SubjectId = 2, Grade = 88.0 },
                new StudentSubject { StudentId = 7, SubjectId = 4, Grade = 91.0 },
                new StudentSubject { StudentId = 7, SubjectId = 5, Grade = 75.0 },
                new StudentSubject { StudentId = 8, SubjectId = 1, Grade = 85.0 },
                new StudentSubject { StudentId = 8, SubjectId = 2, Grade = 90.0 },
                new StudentSubject { StudentId = 9, SubjectId = 1, Grade = 78.0 },
                new StudentSubject { StudentId = 9, SubjectId = 3, Grade = 82.0 },
                new StudentSubject { StudentId = 10, SubjectId = 3, Grade = 82.0 },
                new StudentSubject { StudentId = 10, SubjectId = 2, Grade = 88.0 }

            );
        }
    }