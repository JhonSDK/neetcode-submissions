// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//     pub val: i32,
//     pub left: Option<Rc<RefCell<TreeNode>>>,
//     pub right: Option<Rc<RefCell<TreeNode>>>,
// }
//
// impl TreeNode {
//     #[inline]
//     pub fn new(val: i32) -> Self {
//         TreeNode {
//             val,
//             left: None,
//             right: None,
//         }
//     }
// }

use std::rc::Rc;
use std::cell::RefCell;

impl Solution {
pub fn insert_into_bst(root: Option<Rc<RefCell<TreeNode>>>, val: i32) -> Option<Rc<RefCell<TreeNode>>> {
    match root {
        None => Some(Rc::new(RefCell::new(TreeNode::new(val)))),
        Some(node) => {
            {
                let mut node_ref = node.borrow_mut();
                if val > node_ref.val {
                    node_ref.right = Self::insert_into_bst(node_ref.right.take(), val);
                } else if val < node_ref.val {
                    node_ref.left = Self::insert_into_bst(node_ref.left.take(), val);
                }
            }
            Some(node)
        }
    }
}
}
