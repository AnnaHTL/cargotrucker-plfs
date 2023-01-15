// Start your Cargo Trucker program here


int width = ReadInt("Enter board width: ");
int hight = ReadInt("Enter board hight: ");


// cut the lawn up and down
for (int i = 0; i < width - 1; i++)
{
    MoveUp(hight);
    MoveDown(hight);
}
MoveUp(hight);
WriteLine($"{2 * width - 1} heaps of grass were unloaded.");
WriteLine($"A lawn of {width * hight} m² was mowed.");



void MoveDown(int len)
{
    LeftN(2);
    ForwardN(len-1);
    PlaceBox();
    Left();
    Forward();
}

void MoveUp(int len)
{
    Left();
    ForwardN(len-1);
    PlaceBox();
}

void LeftN(int count)
{
    for (int i = 0; i < count; i++)
    {
        Left();
    }
}

void ForwardN(int count)
{
    for (int i = 0; i < count; i++)
    {
        Forward();
    }
}