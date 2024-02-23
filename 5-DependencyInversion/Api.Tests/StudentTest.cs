using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;
using DependencyInversion.Repository;
using DependencyInversion.Models;

namespace Api.Tests;


public class StudentTest 
{
    // IStudentRepository _studentRepository;
    // ILogbook _logbook;

    // [Fact]
    // public void GetStudent()
    // {
    //     var studentController = new StudentController(_studentRepository, _logbook);

    //     var resultGetStudents = studentController.Get();

    //     Assert.NotNull(resultGetStudents);
    //     Assert.Equal(3, resultGetStudents.Count());
    // }
    Mock<ILogbook> LogbookMock = new Mock<ILogbook>();
    Mock<IStudentRepository> studentRepositoryMock = new Mock<IStudentRepository>();

    [Fact]
    public void GetStudent()
    {
        studentRepositoryMock.Setup(p=> p.GetAll())
                                        .Returns(new List<Student>()
                                        {
                                            new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                                            new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                                            new Student(3, "José Molina", new List<double>() { 2, 3 })
                                        });

        var studentController = new StudentController(studentRepositoryMock.Object, LogbookMock.Object);

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    [Fact]
    public void AddTests()
    {
        var student = new Student()
        {
            Fullname = "Raymundo Solis",
            Grades = new List<double>() { 4, 6.5 },
            Id = 1
        };
        var studentController = new StudentController(studentRepositoryMock.Object, LogbookMock.Object);

        var result = studentController.Add(student);
        Assert.IsType<int>(result);
        Assert.True(result > 0);
    }
}