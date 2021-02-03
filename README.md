# MCQ-Loader
A program that fetches MCQs from a database, and randomly shuffles answers and the order of the questions.

## How it works
Place an Access 2000 (or any Microsoft.Jet.OLEDB.4.0 compatible database) database in the same location as the executable. The app reads from the table 'questions'.

The app expects a table with 5 columns
1. Primary key
2. Question Body
3. Correct answer
4. Incorrect answer 1
5. Incorrect answer 2
6. Incorrect answer 3

For True/False questions, leave columns 4, 5, and 6 empty, and place either "true" or "false" in 3rd column.

![MCQ-Loader example](https://github.com/ahmed-dardery/MCQ-Loader/raw/master/example.png)
