﻿using ExercicioFixacao.Services.Interfaces;

namespace ExercicioFixacao.Services;

public class PaypalService : IOnlinePaymentService
{
    private double FeePercentage = 0.02;
    private double MonthlyInterest = 0.01;

    public double Interest(double amount, int months) {
        return amount * MonthlyInterest * months;
    }

    public double PaymentFee(double amount) {
        return amount * FeePercentage;
    }
}