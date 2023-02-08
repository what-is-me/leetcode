using System.Collections.Generic;
/*
 * @lc app=leetcode.cn id=1233 lang=csharp
 * @lcpr version=21504
 *
 * [1233] 删除子文件夹
 */

// @lc code=start
class TrieNode {
    public Dictionary<string, TrieNode> next;
    public bool tag;
    public TrieNode() {
        next = new Dictionary<string, TrieNode>();
        tag = false;
    }
}
class Trie {
    private List<string> ret;
    private TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    public void Insert(string[] path) {
        TrieNode cur = root;
        foreach (string p in path) {
            if (p == "") continue;
            if (cur.tag) return;
            if (!cur.next.ContainsKey(p)) {
                cur.next[p] = new TrieNode();
            }
            cur = cur.next[p];
        }
        cur.tag = true;
    }
    public IList<string> ToList() {
        TrieNode cur = root;
        ret = new List<string>();
        Dfs(root);
        return ret;
    }
    private void Dfs(
        TrieNode node,
        string curpath = "") {
        if (node.tag) {
            ret.Add(curpath);
            return;
        }
        foreach (var item in node.next) {
            Dfs(item.Value, curpath + "/" + item.Key);
        }
    }
}
public class Solution {
    public IList<string> RemoveSubfolders(string[] folders) {
        Trie trie = new Trie();
        foreach (string folder in folders) {
            trie.Insert(folder.Split('/'));
        }
        return trie.ToList();
    }
}
// @lc code=end

// @lcpr-div-debug-arg-start
// funName=
// paramTypes= []
// returnType=
// @lcpr-div-debug-arg-end


/*
// @lcpr case=start
// ["/a","/a/b","/c/d","/c/d/e","/c/f"]\n
// @lcpr case=end

// @lcpr case=start
// ["/a","/a/b/c","/a/b/d"]\n
// @lcpr case=end

// @lcpr case=start
// ["/a/b/c","/a/b/ca","/a/b/d"]\n
// @lcpr case=end

 */


