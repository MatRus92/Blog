# ZLE
def print_z():
    z = z + 100

    print(z)

z = 42
print_z()

# DOBRZE
def print_z():
    global z
    z = z + 100

    print(z)

z = 42
print_z()









def print_y():
    print(y)

y = 42
print_y()
















x = 1990

def print_x():
    x = 1992
    print(x)


print(x)
x = 1990
print_x()