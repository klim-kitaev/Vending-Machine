# Vending-Machine
##Техническое задание на разработку виртуального аппарата по продаже кофе (Vending Machine)
​
​
####Описание:
​
    • Смоделировать работу VM по продаже кофе, чая и т.д. реализовать описанные сценарии работы.
    • Рисовать VM в деталях не требуется, достаточно схематичски расположить контролы на форме обозначающие кошелек и VM.
​
####Сценарии Использования:
​
#####Система показывает кошелек пользователя (кол-во монет разного достоинства)
​
    1 руб = 10 штук (начальные данные)
    2 руб = 30 штук
    5 руб = 20 штук
    10 руб = 15 штук
​
#####Система показывает ассортимент товаров для продажи, стоимость и остаток товара
​
    Чай = 13 руб, 10 порций. (начальные данные)
    Кофе = 18 руб, 20 порций.
    Кофе с молоком = 21 руб, 20 порций.
    Сок = 35 руб = 15 порций.
​
#####Система показывает кошелек VM для сдачи (кол-во монет разного достоинства)
​
    1 руб = 100 штук (начальные данные)
    2 руб = 100 штук
    5 руб = 100 штук
    10 руб = 100 штук
​
#####Пользователь может ввнести монеты в монетоприемник VM нажав на монету (или кнопку "внести" рядом с соотвествующей монетой) в своем кошелке.
​
    • При этом кол-во монет в кошелке пользователя соотвествущего достоинства должно измениться.
    • VM должна обновить поле "Внесенная сумма".
​
#####Пользователь может запросить назад остаток внесенной суммы нажав кнопку "Сдача" на VM
​
    • При этом кол-во монет в кошелке пользователя должно измениться.
    • VM должна обновить поле "Внесенная сумма".
    • Внесенная сумма возвращается целиком, при этом сумма возвращается наименьшим кол-вом монет. (напр: 23 руб = 2 х 10 руб + 1 х 2 руб + 1 х 1 руб). При этом возможно изменение кол-во монет в кошелке VM.
​
#####Пользователь может купить товар нажав на товар (или на кнопку рядом с соотвествующим товаром) на VM
​
    • Если стоимость товара <= "Внесенной суммы" товар выдается пользователю, "Внесенная сумма" уменьшается на цену товара и сумма зачисляется в кошелек VM (см. п. 3). Пользователю показывается MessageBox с текстом "Спасибо!"
    • Если стоимость товара > "Внесенной суммы" пользователю выдается MessageBox с текстом "Недостаточно средств"
​
#####Пользователь может повторить п.4. п.5. п.6. в произвольной последовательности.
