// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Agregação");


var professor = new Professor("Carlos", "Quimica");
var professor1 = new Professor("Maria", "Ingles");
var professor2 = new Professor("Ana", "Matematica");
var professor3 = new Professor("Paulo", "Literatura");

var dep = new Departamento("Exatas");
dep.IncluirProfessor(professor);
dep.IncluirProfessor(professor2);
dep.ListaProfessores();

var dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(professor1);
dep2.IncluirProfessor(professor3);
dep2.ListaProfessores();