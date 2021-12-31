import copy

def change_function(myList):
    myList[0] = 1111


my_list = [0, 1, 2, 3, 4, 5]
print(my_list)
change_function(copy.deepcopy(my_list))
print(my_list)



def change_function(myList):
    myList[0] = 1111


my_list = [0, 1, 2, 3, 4, 5]
print(my_list)
change_function(my_list.copy())
print(my_list)


def change_function(myList):
    myList[0] = 1111


my_list = [0, 1, 2, 3, 4, 5]
print(my_list)
change_function(my_list)
print(my_list)