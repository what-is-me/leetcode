/*
 * @lc app=leetcode.cn id=1825 lang=cpp
 * @lcpr version=21110
 *
 * [1825] 求出 MK 平均值
 */
#include <bits/stdc++.h>
using namespace std;
// @lc code=start
class Multiset : public multiset<int> {
    int sum = 0;

public:
    void insert(int x) {
        multiset<int>::insert(x);
        sum += x;
    }
    template <typename Iterator>
    void insert(Iterator first, Iterator last) {
        multiset<int>::insert(first, last);
        for (auto it = first; it != last; it++) {
            sum += *it;
        }
    }
    std::multiset<int>::iterator erase(std::multiset<int>::const_iterator it) {
        sum -= *it;
        return multiset<int>::erase(it);
    }
    int getSum() {
        return sum;
    }
};
class MKAverage {
    list<int> q;
    array<Multiset, 3> L;
    int m, k, n;
    void balance(Multiset& a, Multiset& b) {
        while (*prev(a.end()) > *b.begin()) {
            int A = *prev(a.end());
            int B = *b.begin();
            a.erase(prev(a.end()));
            b.erase(b.begin());
            b.insert(A);
            a.insert(B);
        }
    }
    void balance() {
        while (L[0].size() > k + n) {
            L[2].insert(*L[0].rbegin());
            L[0].erase(prev(L[0].end()));
        }
        while (L[0].size() > k) {
            L[1].insert(*L[0].rbegin());
            L[0].erase(prev(L[0].end()));
        }
        while (L[1].size() > n) {
            L[2].insert(*L[1].rbegin());
            L[1].erase(prev(L[1].end()));
        }
        balance(L[0], L[1]);
        balance(L[1], L[2]);
    }
    void del(int num) {
        for (auto& l : L) {
            auto it = l.find(num);
            if (it != l.end()) {
                l.erase(it);
                break;
            }
        }
    }
    void add(int num) {
        L[0].insert(num);
    }

public:
    MKAverage(int m, int k) : m(m), k(k), n(m - k * 2) {}

    void addElement(int num) {
        if (q.size() < m) {
            q.push_back(num);
            if (q.size() == m) {
                L[0].insert(q.begin(), q.end());
                balance();
            }
        } else {
            int de = q.front();
            q.pop_front();
            q.push_back(num);
            del(de);
            add(num);
            balance();
        }
    }

    int calculateMKAverage() {
        if (L[1].empty()) return -1;
        return L[1].getSum() / L[1].size();
    }
};

/**
 * Your MKAverage object will be instantiated and called as such:
 * MKAverage* obj = new MKAverage(m, k);
 * obj->addElement(num);
 * int param_2 = obj->calculateMKAverage();
 */
// @lc code=end

/*
// @lcpr case=start
//
// @lcpr case=end

 */
