using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ_stack_forms
{
    class OPZ
    {
        private string _inputStr;
        private string _outStr = "";//строка для вывода ответа опз

        private bool check = true;

        private Stack<char> stOperation = new Stack<char>();//Стэк для перевода в опз
        private Stack<double> stNum = new Stack<double>();//Стэк для ответа

        private List<string> listOutStr = new List<string>();

        public string CreateOPZ(string inputStr)//преобразование в опз
        {
            _inputStr = inputStr.Replace(" ", ""); // удаляем пробелы из примера

            foreach (var el in _inputStr)//перебор всех элементов в тексте примера
            {
                bool cont = false;
                if (Char.IsNumber(el))
                { //если элемент цифра добавляем сразу к ответу
                    _outStr += el;
                    continue;
                }  

                else if (Char.IsLetter(el)) { _outStr += el; check = false; continue; }

                listOutStr.Add(_outStr);
                _outStr = "";
                cont = true;
                if(cont)
                {
                    switch (el)
                    {
                        case '(': //открывающую скобку всегда добавляем в стэк
                            stOperation.Push(el);
                            break;

                        case '+':
                            if (stOperation.Count == 0) stOperation.Push(el); //если стэк пусть добавляем в него

                            else if (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '*' || stOperation.Peek() == '/' || stOperation.Peek() == '^' || stOperation.Peek() == '(') // если в стэке лежит один из этих операций мы добавляем их к ответу пока стэк не закончится или не встрети открывающую скобку, после данный знак добавляем в стэк
                            {
                                while (stOperation.Count != 0 && (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '*' || stOperation.Peek() == '/' || stOperation.Peek() == '^')) listOutStr.Add( stOperation.Pop().ToString());

                                stOperation.Push(el);
                            }
                            break;

                        case '-':
                            if (stOperation.Count == 0) stOperation.Push(el); //если стэк пусть добавляем в него

                            else if (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '*' || stOperation.Peek() == '/' || stOperation.Peek() == '^' || stOperation.Peek() == '(') // если в стэке лежит один из этих операций мы добавляем их к ответу пока стэк не закончится или не встрети открывающую скобку, после данный знак добавляем в стэк
                            {
                                while (stOperation.Count != 0 && (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '*' || stOperation.Peek() == '/' || stOperation.Peek() == '^')) listOutStr.Add(stOperation.Pop().ToString());
                                stOperation.Push(el);
                            }
                            break;

                        case '*':
                            if (stOperation.Count == 0) stOperation.Push(el); //если стэк пусть добавляем в него

                            else if (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '(') stOperation.Push(el); //умножение и деление может добавляться поверх + и -, из стэка удаляется операция только если встретиться умножение с умноением, так же с делением, + и - удаляют из стэка все кроме (. возведение в степень не удаляет ничего

                            else if (stOperation.Peek() == '*' || stOperation.Peek() == '/')
                            {
                                listOutStr.Add(stOperation.Pop().ToString());
                                stOperation.Push(el);
                            }

                            break;

                        case '/':
                            if (stOperation.Count == 0) stOperation.Push(el);

                            else if (stOperation.Peek() == '-' || stOperation.Peek() == '+' || stOperation.Peek() == '(') stOperation.Push(el);

                            else if (stOperation.Peek() == '*' || stOperation.Peek() == '/')
                            {
                                listOutStr.Add(stOperation.Pop().ToString());
                                stOperation.Push(el);
                            }

                            break;

                        case '^':
                            if (stOperation.Count == 0) stOperation.Push(el);

                            else stOperation.Push(el);

                            break;
                        case ')':// закрывающая скобка удаляет все из стэка пока не встретит открывающую
                            while (stOperation.Peek() != '(') listOutStr.Add(stOperation.Pop().ToString());

                            stOperation.Pop();

                            break;

                    }
                }

            }

            
            if(_outStr.Length != 0)
            {
                listOutStr.Add(_outStr);
            }

            if (stOperation.Count != 0) //если в стэке что то осталось добавляем их к ответу
            {
                while (stOperation.Count != 0)
                {
                    listOutStr.Add(stOperation.Pop().ToString());
                }
            }
            if(stOperation.Count == 0)
            {
                _outStr = "";
                for(int i = 0; i < listOutStr.Count; i++)
                {
                    _outStr += listOutStr[i];
                }
            }

            return _outStr;
            //CalculationOPZ(_outStr);
        }

        public string CalculationOPZ()//высчитывание ответа через опз
        {
            _inputStr = "";
            if (check)
            {
                

                double pushEl;
                double pushSum; //ложиться ответ операции над двумя последними числами из стэка
                double num2;
                double num1;//в num1 num2 кладутся 2 последних числа из стэка для правильной операции над ними(нпример, если изначально пример был 3-2, то в стэке он будет лежать как 2 и 3, и при операции получится 2 - 3, что не верно)
                string num = "";
                
                foreach (string el in listOutStr)
                {

                    if (double.TryParse(el, out pushEl)) { stNum.Push(pushEl); }

                    else
                    {
                        switch (el) //если элемент операция, мы остаем последние 2 числа из стэка производим операцию и ответ кладем обратно в стэк.
                        {
                            case "+":
                                num2 = stNum.Pop();
                                num1 = stNum.Pop();
                                pushSum = num1 + num2;
                                stNum.Push(pushSum);
                                Console.WriteLine("operation: +, sum: {0}", pushSum);
                                break;

                            case "-":
                                num2 = stNum.Pop();
                                num1 = stNum.Pop();
                                pushSum = num1 - num2;
                                stNum.Push(pushSum);
                                Console.WriteLine("operation: -, sum: {0}", pushSum);
                                break;

                            case "*":
                                num2 = stNum.Pop();
                                num1 = stNum.Pop();
                                pushSum = num1 * num2;
                                stNum.Push(pushSum);
                                Console.WriteLine("operation: *, sum: {0}", pushSum);
                                break;

                            case "/":
                                num2 = stNum.Pop();
                                num1 = stNum.Pop();
                                pushSum = num1 / num2;
                                stNum.Push(pushSum);
                                Console.WriteLine("operation: /, sum: {0}", pushSum);
                                break;

                            case "^":
                                num2 = stNum.Pop();
                                num1 = stNum.Pop();
                                pushSum = Convert.ToInt32(Math.Pow(num1, num2));
                                stNum.Push(pushSum);
                                Console.WriteLine("operation: ^, sum: {0}", pushSum);
                                break;
                        }
                    }
                }

                string ans = stNum.Pop().ToString(); //в конце в стэке остается один элемент, его мы добавляем в ans

                return ans;
            }

            check = true;
            return _inputStr;
        }
    }
}
