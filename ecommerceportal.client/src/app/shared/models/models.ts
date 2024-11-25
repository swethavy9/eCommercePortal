export interface CustomerRequest {
    mobileNumber: string;
    customerName: string;
    groceries: Groceries[];
}

export interface Groceries {
    groceryName: string;
    quantity: number;
    amount: number;
}

export interface CustomerResponse {
    mobileNumber: string;
    customerName: string;
    totalAmount: number;
    totalRewardPoints: number;
    transactions: TransactionResponse[];
}

export interface TransactionResponse {
    transactionId: number;
    customerMobileNumber: string;
    groceryName: string;
    amount: number;
    quantity: number;
    rewardPoints: number;
    transactionDate:Date;
}

