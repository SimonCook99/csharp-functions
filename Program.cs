

int[] array = { 1, 2, 3 };
StampaArray(array);

Console.WriteLine("\nIl quadrato è: " + Quadrato(9));

int[] arrayElevato = ElevaArrayAlQuadrato(array);

for (int i = 0; i < arrayElevato.Length; i++) {
    Console.WriteLine(arrayElevato[i]);
}

Console.WriteLine("La somma è: " + SommaElementiArray(array));


//funzione 1, stampa array
void StampaArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        if (i == 0) { 
            Console.Write($"[{array[i]},");
        }else if (i == array.Length - 1){
            Console.Write($"{array[i]}]");
        }
        else{
            Console.Write($"{array[i]},");
        }
    }
}

//funzione 2, quadrato di un elemento
int Quadrato(int numero){
    return numero * numero;
}

//funzione 3, array elevato al quadrato
int[] ElevaArrayAlQuadrato(int[] array){
    int[] nuovoArray = (int[])array.Clone();

    for (int i = 0; i < nuovoArray.Length; i++){
        nuovoArray[i] *= nuovoArray[i];
    }

    return nuovoArray;
}

//funzione 4, somma elementi array
int SommaElementiArray(int[] array){
    int somma = 0;

    for(int i = 0; i<array.Length; i++){
        somma += array[i];
    }

    return somma;
}