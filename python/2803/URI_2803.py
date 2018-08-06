estado = str(input())
listaEstados = ['acre', 'amapa', 'amazonas', 'para', 'rondonia', 'roraima', 'tocantins']
if listaEstados.__contains__(estado):
    print('Regiao Norte')
else:
    print('Outra regiao')