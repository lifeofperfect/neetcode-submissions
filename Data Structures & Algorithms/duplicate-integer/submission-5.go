func hasDuplicate(nums []int) bool {
    see := make(map[int]struct{});

    for _, n := range nums {
        if _, exists := see[n]; exists {
            return true;
        }
        see[n] = struct{}{}
    }

    return false;
}
