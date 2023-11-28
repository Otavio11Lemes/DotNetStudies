


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila){
    Console.WriteLine(item);
}
//removendo elemento
fila.Dequeue();

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);


foreach(int item in pilha){
    Console.WriteLine(item);
}

pilha.Pop();
// Dicionario

Dictionary<String, String> estados = new Dictionary<string, string>();

estados.Add("SP", "Sao Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("GO", "Goiás");

foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key} = Estado{item.Value}");
}

estados.Remove("MG");
estados["SP"] = "São Paulo";

foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key} = Estado {item.Value}");
}

String chave = "BA";
Console.WriteLine($"Verificando o elemento:{chave}");

if(estados.ContainsKey(chave)){
    Console.WriteLine("valor exitente");
}
else{
    Console.WriteLine("Valo não existente");
}