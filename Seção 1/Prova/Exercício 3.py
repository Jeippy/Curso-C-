x = input().split(" ")

if int(x[0]) == 1:
    total = float(x[1]) * 4.00
if int(x[0]) == 2:
    total = float(x[1]) * 4.50
if int(x[0]) == 3:
    total = float(x[1]) * 5.00
if int(x[0]) == 4:
    total = float(x[1]) * 2.00
if int(x[0]) == 5:
    total = float(x[1]) * 1.50

print("Total: R$ {:.2f}".format(total))