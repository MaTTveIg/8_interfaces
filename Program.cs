using _8_interfaces;

StackCustom stack = new();

for (int i = 0; i < 10; ++i)
    stack.Push(i);

//stack.ShowEven();
stack.ShowOdd();