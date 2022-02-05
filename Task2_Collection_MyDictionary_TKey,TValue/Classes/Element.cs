class Element
{
    private string _field1;
    private int _field2;
    private int _field3;

    public Element(string s, int a, int b)
    {
        _field1 = s;
        _field2 = a;
        _field3 = b;
    }

    public string Field1 { get { return _field1; } set { _field1 = value; } }
    public int Field2 { get { return _field2; } set { _field2 = value; } }
    public int Field3 { get { return _field3; } set { _field3 = value; } }
}
