using Composite;

FuncionarioComposite tree = new ("Bill Gate");
FuncionarioLeaf liderados1 = new ("Steve Jobs");
FuncionarioLeaf liderados2 = new("Jeff Bezos");

FuncionarioComposite liderados3 = new("Elon Musk");
FuncionarioLeaf liderados4 = new("Gabriel");
FuncionarioLeaf liderados5 = new("Pedro");

tree.Add(liderados1);
tree.Add(liderados2);
tree.Add(liderados3);

liderados3.Add(liderados4);
liderados3.Add(liderados5);

Console.WriteLine(tree.Operation());
Console.WriteLine(liderados3.Operation());