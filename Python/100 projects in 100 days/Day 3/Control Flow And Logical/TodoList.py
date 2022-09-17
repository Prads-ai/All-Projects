# ------------------------------------------------------------------
# Description: A simple console to-do list app that allows a user to add and delete tasks and also display a summary of the completed tasks.
# Due: 9/16/2022
# Author:  Pradsley D'Haiti
# version 1.0 
# ---------------------------------------------------------------------


header = """  _____         _           
 |_   _|__   __| | ___  ___ 
   | |/ _ \ / _` |/ _ \/ __|
   | | (_) | (_| | (_) \__ 
   |_|\___/ \__,_|\___/|___/"""


print(header)
# empty list of todos
todos = []
complete_todos = []


while True:
    #Displaying the to_do list
    for i in range(len(todos)):
        i+=1
        print(f"{i}) {todos[i-1]}")
    print("*****************")
    print("Add a todo. type h for help")
    userCommand = input("> ")

    if userCommand == 'q':
        break
    #
    elif userCommand.isnumeric():
        index = int(userCommand) - 1
        if index >= len(todos):
            print("There is no todo with that number")
        else:
            #The pop method return the value deleted, i add this value inside of another array
            completeTask = todos.pop(index)
            complete_todos.append(completeTask)

    else:
        todos.append(userCommand)

#displaying all the completed tasks
if complete_todos:
        print(f"You have completed : {len(complete_todos)} tasks today")
        for i in range(len(complete_todos)):
            print(f"{i}) {complete_todos[i]} ✅")
        print("Keep up the good work")
print("See you next time")
