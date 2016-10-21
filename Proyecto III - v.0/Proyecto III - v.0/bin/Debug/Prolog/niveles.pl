dificultad(facil,5).
dificultad(medio,10).
dificultad(dificil,15).

cargar(A):- exists_file(A),consult(A).
