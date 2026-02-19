# 📊 Employee Salary Analyzer (C# + LINQ)
## Aplicação console desenvolvida em C# que realiza a leitura de um arquivo .csv contendo dados de funcionários e utiliza LINQ para filtrar, ordenar e realizar operações matemáticas com base nessas informações.

Este projeto tem como objetivo praticar:
- Leitura de arquivos com StreamReader
- Manipulação de listas
- Uso de LINQ
- Boas práticas com C#
- Programação orientada a objetos

## 🚀 Funcionalidades

O sistema é capaz de ler um arquivo .csv contendo Nome, Email e Salário de um funcionário

✔ Solicitar um valor de salário como parâmetro

✔ Mostrar:

📧 Emails dos funcionários que ganham mais que o valor informado

💰 Soma dos salários dos funcionários cujo nome começa com a letra 'M'

```bash
#📁 Estrutura do Projeto
Course
│
├── Program.cs
│
└── Entities
    └── Employee.cs
```

## 🧠 Conceitos Utilizados
* StreamReader	Leitura de arquivos
* File.OpenText	Abertura de arquivo
* List<T>	Lista genérica
* LINQ Where	Filtragem
* LINQ OrderBy	Ordenação
* LINQ Select	Projeção
* LINQ Sum	Soma
* CultureInfo	Formatação numérica
* Programação Orientada a Objetos	Modelagem com classe
```bash
📄 Exemplo de Arquivo CSV

Exemplo: employees.txt

Maria Silva,maria@gmail.com,3200.00
Alex Brown,alex@gmail.com,1900.00
Marco Santos,marco@gmail.com,3500.00
Ana Souza,ana@gmail.com,2800.00
```
## ▶ Como Executar
1. Clone o repositório
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```
3. Abra no Visual Studio ou VS Code
4. Execute o projeto
```bash
dotnet run
```
5. Entrada esperada no console
```bash
Enter full file path:
C:\temp\employees.txt

Enter salary:
2000.00
```
5. Saída esperada
```bash
Emails for those salary is more than 2000
ana@gmail.com
maria@gmail.com
marco@gmail.com

6700.00
```

## 🧮 LINQ Utilizado
* Filtrar e ordenar emails
  var r1 = lista
  .Where(e => e.Salary > salaryparam)
  .OrderBy(e => e.Email)
  .Select(e => e.Email);

* Somar salários com nome iniciando em M
  var r2 = lista
  .Where(e => e.Name.StartsWith('M'))
  .Sum(e => e.Salary);


## 🛠 Tecnologias

- C#
- .NET
- LINQ
- StreamReader

## 👨‍💻 Autor Enzo Spíndola
Estudante de Análise e Desenvolvimento de Sistemas

## ⭐ Contribuição: Sinta-se livre para contribuir, melhorar ou usar como base para estudos.
