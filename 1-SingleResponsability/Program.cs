using SingleResponsability;

StudentRepository studentRepository = new();
ExportManager exportManager = new();
exportManager.ExportStudent(studentRepository);
Console.WriteLine("Proceso Completado");