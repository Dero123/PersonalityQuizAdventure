# PersonalityQuizAdventure

## Description:

#### This personality quiz adventure to determine which anime you should watch next! There will be five possible anime recommendation made based on the players personality.

## OverView:
#### The ultimate goal of the Personality Quiz Adventure is to entertain the user and help them discover a new anime to watch. The Personality Quiz Adventure functions by giving the user questions and questions based on the answer to the previous questions. Ultimately, the quiz ends by giving the user the results of their quiz.

## High Level Design:
#### 1. Starts by creating the questions
#### 2. Sets 'Questions' to be the first question
#### 3. Displays questions and answers 
#### 4. Receives users response
#### 5. Sets questions based on users response
#### 6. Checks if the current question has an answer and loops back to 'Displays questions and answers' otherwise....
#### 7. Displays a Game Over screen



### FlowChart:

![personality quiz adventure](Images/PersonalityQuizAdventure.png)

## Methods and Classes:
#### The two methods I have chosen are:
#### - static int AskQuestion(Question)
#### - static int GetValidAnswer(List<string> answer);


### Question Class:
#### - List<string>answer
#### - List<Question>result
#### - String Question

