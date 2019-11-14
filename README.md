# SAaCSimLab
 Вариант 18 для 3 лабораторной работы по САиММод.

## Задание

Схема системы:

![Схема](ReadmeImg/scheme.png)

На схеме условно обозначены:

![Легенда](ReadmeImg/legend.png)

* Р<sub>отк</sub> – вероятность отказа;  
* А – абсолютная пропускная способность; 
* W<sub>с</sub> – среднее время пребывания заявки в системе. 

|ρ|π<sub>1</sub>|π<sub>2</sub>|Цель исследования|
|---|---|---|-----------|
|0,5|0,6|0,4|Р<sub>отк</sub>, А, W<sub>с</sub>|

q = { 0, 1 } – количество заявок в очереди;  
π<sub>1</sub> = { 0, 1, B } – состояние канала 1;  
π<sub>2</sub> = { 0, 1 } – количество заявок в канале 2;  
0 – заявок нет, 1 – одна заявка, B – заблокирован;  

Общий вид кодировки состояния системы:  
  { π<sub>1</sub>, q, π<sub>2</sub> }
