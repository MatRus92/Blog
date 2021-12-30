from enum import Enum

Enum_Samochody = Enum('Samochody',
                      {'AUDI': 'Audi', 'MERCEDES': 'Mercedes', 'OPEL': 'Opel', 'BMW': 'BMW', 'TOYOTA': 'Toyota'})


def car_country(car):
    if car == Enum_Samochody.AUDI.value:
        print('Niemcy')
    elif car == Enum_Samochody.MERCEDES.value:
        print('Niemcy')
    elif car == Enum_Samochody.OPEL.value:
        print('Niemcy')
    elif car == Enum_Samochody.BMW.value:
        print('Niemcy')
    elif car == Enum_Samochody.TOYOTA.value:
        print('Japonia')
    else:
        print('Brak')

car_country('Toyota')
car_country('Opel')
car_country('Kia')

print(list(Enum_Samochody))
