x = int(input())
dentro = 0
fora = 0

for x in range(x):
    a = int(input())
    if 10 <= a <= 20:
        dentro += 1
    else:
        fora += 1

print('{:d} in\n{:d} out'.format(dentro, fora))