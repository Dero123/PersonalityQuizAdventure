# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

For people to discover a new anime or manga  

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can display questions, receive answers, and goes through a series of questions.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The user answers two questions then receives a result based on the users answers.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
 
Question Question_C = new Question();

Question_C.result.Add(Question_F);
Question_C.result.Add(Question_G);

Question_C.question = "Do you prefer action or slice of life manga?";

Question_C.answers.Add("Action");
Question_C.answers.Add("Slice of Life");
Question_C.isEnd = false;
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (string answer in question.answers)
{
    Console.WriteLine($"{optionNumbers}. {answer}");
    optionNumbers = optionNumbers + 1;
}
return GetValidAnswer(question.answers);
}

```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

* In the first segment the variable name is Question_C.answers
* In the second segment the variable name is question.answers. This is because the variable from the first segment is passed as an argument into the second segment. 


### 3b iv.

Describes what the data contained in the list represents in your program

The list of all answers and results in Question_C.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

The list makes it possible to easily add several new questions and answers to the list later on. Without the list I would need to compensate with a console.WriteLine for each individual question and answer rather than using a foreach loop therefore managing the complexity of my program.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int AskQuestion(Question question)
{


    if (question == null)
    {
        throw new Exception("You cannot pass in a null value.");
    }

    if (question.answers.Count == 0)
    {
        throw new Exception("You cannot pass in a list with 0 elements.");
    }



    Console.WriteLine(question.question);
    int optionNumbers = 1;


    foreach (string answer in question.answers)
    {
        Console.WriteLine($"{optionNumbers}. {answer}");
        optionNumbers = optionNumbers + 1;
    }
    return GetValidAnswer(question.answers);
}
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
int ix = AskQuestion(Current);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

* The identified procedure asks the player a question and receives a response.
* The procedure is important because it is used every time a question is asked and a response is given.
 
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1.Display the question
2.Loop through each answer and display it
3.Use the GetValidAnswer method to get the user's response
4.Return the user's response

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

AskQuestion(null);

Second call:

Question question_Z = new Question();
question_Z.question = "What is your favorite animal?";
//question_Z.answers is initialized without any values
AskQuestion(question_Z);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Tests that the procedure successfully fails when AskQuestion is null by executing the body of the if statement.

Condition(s) tested by the second call:

Tests that the procedure successfully fails when there are no answers for a question by executing the body of the if statement.


### 3d iii.

Result of the first call:

When the procedure is called with a null value an exception is thrown which says "You cannot pass in a null value".

Result of the second call:

When the procedure is called without an answer an exception is thrown which says "You cannot pass in a list with 0 elements.".