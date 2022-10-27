x = input().split(" ")
y = input().split(" ")

precoX = float(x[1]) * float(x[2])
precoY = float(y[1]) * float(y[2])
total = precoX + precoY

txt = "VALOR A PAGAR: R$ {:.2f}"

print(txt.format(total))