import math

x = input().split(" ")
a = float(x[0])
b = float(x[1])
c = float(x[2])

txt = "Impossível calcular"
x1 = 0
x2 = 0

if a != 0:
    delta = b**2 - (4*a*c)
    print(delta)
    if delta > 0:
        x1 = (-b + math.sqrt(delta))/(2*a)
        x2 = (-b - math.sqrt(delta))/(2*a)
        txt = "X1 = {:.5f}\nX2 = {:.5f}"

print(txt.format(x1, x2))