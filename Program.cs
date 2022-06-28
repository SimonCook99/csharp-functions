

//SEZIONE ARRAY PREDEFINITO
//int[] array = { 2, 6, 7, 5, 3, 9 };
//StampaArray(array);

//Console.WriteLine("\nIl quadrato è: " + Quadrato(9));

//int[] arrayElevato = ElevaArrayAlQuadrato(array);

//StampaArray(array);
//StampaArray(arrayElevato);


//Console.WriteLine("La somma è: " + SommaElementiArray(array));
//Console.WriteLine("La somma è: " + SommaElementiArray(arrayElevato));


//SEZIONE ARRAY DEFINITO DALL'UTENTE (inclusa la lunghezza)
Console.WriteLine("Quanti numeri vuoi inserire?");
int lunghezzaArray = int.Parse(Console.ReadLine());

int[] arrayUtente = new int[lunghezzaArray];

for (int i = 0; i < arrayUtente.Length; i++){
    Console.WriteLine($"Inserisci l'elemento {i + 1}");
    arrayUtente[i] = int.Parse(Console.ReadLine());
}

StampaArray(arrayUtente);

int[] arrayElevato = ElevaArrayAlQuadrato(arrayUtente);

StampaArray(arrayElevato);
StampaArray(arrayUtente);

Console.WriteLine("La somma degli elementi è: " + SommaElementiArray(arrayUtente));
Console.WriteLine("La somma degli elementi al quadrato è: " + SommaElementiArray(arrayElevato));




//funzione 1, stampa array
void StampaArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        if (i == 0) { 
            Console.Write($"[{array[i]},");
        }else if (i == array.Length - 1){
            Console.Write($"{array[i]}]");
        }else{
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