def arguments(*args):
    for x in args:
        print(x)


arguments(1, 2, 3, 4)


def arguments(x, y, z):
    if z:
        print(y + 10)
        print(x)

arguments(z=True, x='Mateusz', y=100)




def arguments(x, y, z):
    if z:
        print(y + 10)
        print(x)

arguments('Mateusz', 100, True)