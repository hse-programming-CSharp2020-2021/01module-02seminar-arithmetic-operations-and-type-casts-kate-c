﻿/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;

namespace Task_05 {
	class Program {
		const string notTriangleMessage = "not a triangle";

		static void Main(string[] args) {
			// TODO : Сменить локаль на "ru-RU". 

			double a, b, c;
			// TODO : Считать 3 стороны треугольника.


			// TODO : Проверить неравенство треугольника и поместить в 
			// результирующую строку notTriangleMessage 
			// или площадь треугольника.
			string result = ;

			Console.WriteLine(result);
            // fdfvdv
		}

		static double Sqare(double a, double b, double c) {
			// TODO : Реализоать вычисление площади по формуле Герона. Ну или что-нибудь более извращённое 🙃.
			return;
		}
	}
}
